import { Component, OnInit } from '@angular/core';

@Component({
    /**
     * Should have unique selector name
     */
    selector: 'app-server',
    templateUrl: 'server.component.html'
})

export class ServerComponent implements OnInit {
    serverId = 10;
    serverStatus = 'online';

    getServerStatus(){
        return this.serverStatus;
    }

    constructor() { }

    ngOnInit() { }
}