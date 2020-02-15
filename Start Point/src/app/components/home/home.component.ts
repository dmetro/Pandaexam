import { Component, OnInit } from '@angular/core';

import { HomeService } from "../../core/services/home.service";
import { data } from './data';

@Component({
    selector: 'home',
    templateUrl: 'home.component.html'
})

export class HomeComponent implements OnInit {

    result: data[];

    constructor(private hserv: HomeService) {
        this.hserv.get().subscribe((data) => {
            this.result = data;
            console.log(" this.result", this.result);
        });
    }

    ngOnInit(): void {
    }

}