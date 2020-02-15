import { Component, OnInit } from '@angular/core';

import { HomeService } from "../../core/services/home.service";
import { data } from './data';
import { IntervalObservable } from 'rxjs/observable/IntervalObservable';

@Component({
    selector: 'home',
    templateUrl: 'home.component.html'
})

export class HomeComponent implements OnInit {

    result: data[];
    alive: boolean;

    constructor(private hserv: HomeService) {
        this.alive = true;

    }

    ngOnInit(): void {
        this.hserv.get()
            .first()
            .subscribe((data) => {
                this.result = data;
            });

        IntervalObservable.create(5000)
            .takeWhile(() => this.alive)
            .subscribe(() => {
                this.hserv.get().subscribe((data) => { this.result = data; })
            })
    };

    ngOnDestroy() {
        this.alive = false; // switches your IntervalObservable off
    }
}

