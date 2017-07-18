import { Shipment } from './../models/shipment';
import {Injectable} from '@angular/core';
import {Http, Response} from '@angular/http';
import 'rxjs/Rx';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class ShipmentApiService {
    public values: any;
    private shipmentsUrl = 'http://localhost:62261/api/shipments/';

    constructor(public _http: Http) { }

    getAllShipments() {
        return this._http.get(this.shipmentsUrl)
            .map(res => <Shipment[]>res.json())
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}
