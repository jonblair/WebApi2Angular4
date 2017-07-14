import { Carrier } from './../models/carrier';
import {Injectable} from '@angular/core';
import {Http, Response} from '@angular/http';
import 'rxjs/Rx';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class CarrierApiService {
    public values: any;
    private carriersUrl = 'http://localhost:62261/api/carriers/';

    constructor(public _http: Http) { }

    getAllCarriers() {
        return this._http.get(this.carriersUrl)
            .map(res => <Carrier[]>res.json())
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}
