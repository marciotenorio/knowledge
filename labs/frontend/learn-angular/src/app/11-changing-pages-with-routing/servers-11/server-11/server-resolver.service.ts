import {
  ActivatedRouteSnapshot,
  Resolve,
  RouterStateSnapshot,
} from '@angular/router';
import { Observable } from 'rxjs';
import { Servers11Service } from '../servers-11.service';
import { Injectable } from '@angular/core';

interface Server {
    id: number;
    name: string;
    status: string;
}

@Injectable()
export class ServerResolver implements Resolve<Server> {
    
    constructor(private serverService: Servers11Service) {}

      resolve(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot
    ):
        | Server 
        | Observable<Server>
        | Promise<Server> {
            return this.serverService.getServer(+route.params['id']);
    }
}
