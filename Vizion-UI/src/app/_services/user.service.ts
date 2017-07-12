import { User } from './../models/user';
import {Injectable} from '@angular/core';
import {Http, Response} from '@angular/http';
import 'rxjs/Rx';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class UserApiService {
    public values: any;
    private usersUrl = 'http://localhost:62261/api/users/';

    constructor(public _http: Http) { }

    getAllUsers() {
        return this._http.get(this.usersUrl)
            .map(res => <User[]>res.json())
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}
