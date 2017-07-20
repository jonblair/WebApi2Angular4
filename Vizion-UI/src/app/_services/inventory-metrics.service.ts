import { InventoryPalletMetric } from './../models/inventorypalletmetric';
import {Injectable} from '@angular/core';
import {Http, Response} from '@angular/http';
import 'rxjs/Rx';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class InventoryMetricApiService {
    public values: any;
    private apiUrl = 'http://localhost:62261/api/inventorymetrics/';

    constructor(public _http: Http) { }

    getInventoryPalletMetrics() {
        return this._http.get(this.apiUrl)
            .map(res => <InventoryPalletMetric[]>res.json())
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}
