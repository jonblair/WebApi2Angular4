import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';

import { User } from './../models/user';
import { UserApiService } from './../_services/user.service';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'user-table',
  templateUrl: 'user-table.component.html',
  providers: [UserApiService]
})
export class UserTableComponent implements OnInit {
    errorMessage: string;
    public users: User[];

    constructor(private myUserApiService: UserApiService, private _router: Router) { }
    ngOnInit() {
        this.getAllUsers();
    }

    getAllUsers() {
        this.myUserApiService.getAllUsers()
            .subscribe(
            value => this.users = value,
            error => this.errorMessage = <any>error);
    }

}
