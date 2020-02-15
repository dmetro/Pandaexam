import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { data } from '../../components/home/data';

@Injectable()
export class HomeService {
    

    constructor(private http: Http, private _http: HttpClient) {
    
    }


    //GetHomeMessage(): Observable<any[]> {
    //    return this.http.get(`api/default`)
    //        .map((res: Response) =>  res.json())
    //        .catch((error: any) => Observable.throw(error.json().error || 'Server error'))
    //}


    get(): Observable<any[]> {
        return this._http.get<data[]>(`api/default`)
            .catch(this.handleError);
    }
    private handleError(err: HttpErrorResponse) {
        console.log(err.message)
        return Observable.throw(err.message);
    }
}