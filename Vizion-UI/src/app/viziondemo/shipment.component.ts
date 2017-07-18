import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import * as _ from 'underscore';

import { Shipment } from './../models/shipment';
import { ShipmentApiService } from './../_services/shipment.service';
import { PagerService } from './../_services/index';

@Component({
  selector: 'shipment-table',
  templateUrl: 'shipment.component.html',
  providers: [ShipmentApiService, PagerService]
})
export class ShipmentTableComponent implements OnInit {
    errorMessage: string;
    public shipments: Shipment[];
    filteredUsers: Shipment[];
    pager: any = {};
    pagedItems: any[];

    constructor(private myShipmentApiService: ShipmentApiService,
                private _router: Router,
                private pagerService: PagerService) { }
    ngOnInit() {
        this.myShipmentApiService.getAllShipments()
            .subscribe(
            value => {this.shipments = value; this.setPage(1); },
            error => this.errorMessage = <any>error);
    }

    setPage(page: number) {
        if (page < 1 || page > this.pager.totalPages) {
            return;
        };
        this.pager = this.pagerService.getPager(this.shipments.length, page);
        this.pagedItems = this.shipments.slice(this.pager.startIndex, this.pager.endIndex + 1);
    }

}
