import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import * as _ from 'underscore';

import { Carrier } from './../models/carrier';
import { PagerService } from './../_services/index';
import { CarrierApiService } from './../_services/carrier.service';
import { User } from './../models/user';

@Component({
  selector: 'carrier-table',
  templateUrl: 'carrier.component.html',
  providers: [CarrierApiService, PagerService]
})
export class CarrierTableComponent implements OnInit {
    errorMessage: string;
    public carriers: Carrier[];
    filteredUsers: User[];
    pager: any = {};
    pagedItems: any[];

    constructor(private myCarrierApiService: CarrierApiService,
                private _router: Router,
                private pagerService: PagerService) { }
    ngOnInit() {
        this.myCarrierApiService.getAllCarriers()
            .subscribe(
            value => {this.carriers = value; this.setPage(1); },
            error => this.errorMessage = <any>error);
    }

    setPage(page: number) {
        if (page < 1 || page > this.pager.totalPages) {
            return;
        };
        this.pager = this.pagerService.getPager(this.carriers.length, page, 20);
        this.pagedItems = this.carriers.slice(this.pager.startIndex, this.pager.endIndex + 1);
    }

}
