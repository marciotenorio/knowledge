import { Component, OnInit } from '@angular/core';

@Component({
    /**
     * Should have unique selector name
     */
    selector: 'app-server',
    templateUrl: 'server.component.html',
    styles: [`
        .online {
            color: rgb(30, 184, 81);
        }
    `]
})

export class ServerComponent implements OnInit {
    serverId = 10;
    serverStatus = 'online';

    getServerStatus(){
        return this.serverStatus;
    }

    getColor(){
        return this.serverStatus == 'online' ? 'green' : 'gray';
    }

    constructor() {
        this.serverStatus = Math.random() > 0.5 ? 'online' : 'offline';
     }

    ngOnInit() { }
}