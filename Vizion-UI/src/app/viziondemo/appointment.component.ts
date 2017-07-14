import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import * as _ from 'underscore';

import { Appointment } from '../models/appointment';
import { PagerService } from './../_services/index';
import { AppointmentApiService } from './../_services/appointment.service';
import { User } from './../models/user';

@Component({
  selector: 'appointment-table',
  templateUrl: 'appointment.component.html',
  providers: [AppointmentApiService, PagerService]
})
export class AppointmentTableComponent implements OnInit {
    errorMessage: string;
    public appointments: Appointment[];
    filteredUsers: User[];
    pager: any = {};
    pagedItems: any[];

    constructor(private myAppointmentApiService: AppointmentApiService,
                private _router: Router,
                private pagerService: PagerService) { }
    ngOnInit() {
        this.getAllAppointments();
    }

    getAllAppointments() {
        this.myAppointmentApiService.getAllAppointments()
            .subscribe(
            value => {this.appointments = value; this.setPage(1); },
            error => this.errorMessage = <any>error);
    }

    setPage(page: number) {
        if (page < 1 || page > this.pager.totalPages) {
            return;
        };
        this.pager = this.pagerService.getPager(this.appointments.length, page);
        this.pagedItems = this.appointments.slice(this.pager.startIndex, this.pager.endIndex + 1);
    }

}
