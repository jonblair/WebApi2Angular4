import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import * as _ from 'underscore';

import { User } from './../models/user';
import { UserApiService } from './../_services/user.service';
import { PagerService } from './../_services/index';

@Component({
  selector: 'user-table',
  templateUrl: 'user-table.component.html',
  providers: [UserApiService, PagerService]
})
export class UserTableComponent implements OnInit {
    errorMessage: string;
    public users: User[];
    filteredUsers: User[];
    pager: any = {};
    pagedItems: any[];

    constructor(private myUserApiService: UserApiService,
                private _router: Router,
                private pagerService: PagerService) { }
    ngOnInit() {
        this.myUserApiService.getAllUsers()
            .subscribe(
            value => {this.users = value; this.setPage(1); },
            error => this.errorMessage = <any>error);
    }

    setPage(page: number) {
        if (page < 1 || page > this.pager.totalPages) {
            return;
        };
        this.pager = this.pagerService.getPager(this.users.length, page);
        this.pagedItems = this.users.slice(this.pager.startIndex, this.pager.endIndex + 1);
    }

}
