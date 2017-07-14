import { Appointment } from './../models/appointment';
import {Injectable} from '@angular/core';
import {Http, Response} from '@angular/http';
import 'rxjs/Rx';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class AppointmentApiService {
    public values: any;
    private appointmentsUrl = 'http://localhost:62261/api/appointments/';

    constructor(public _http: Http) { }

    getAllAppointments() {
        return this._http.get(this.appointmentsUrl)
            .map(res => <Appointment[]>res.json())
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}
