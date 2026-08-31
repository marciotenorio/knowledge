import { Component, OnInit } from '@angular/core';

import { Servers11Service } from '../servers-11.service';
import { ActivatedRoute, ActivatedRouteSnapshot, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { CanComponentDeactivate, CanDeactivateGuard } from './can-deactivate.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-edit-server-11',
  templateUrl: './edit-server-11.component.html',
  styleUrls: ['./edit-server-11.component.css'],
})
export class EditServer11Component implements OnInit, CanDeactivateGuard {
  server: { id: number; name: string; status: string };
  serverName = '';
  serverStatus = '';
  allowEdit = false;
  changesSaved = false;

  constructor(
    private servers11Service: Servers11Service,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit() {
    // Getting params and fragments with snapshop (one-time when component are created) and observable
    console.log('queryParamMap snapshot: ', this.route.snapshot.queryParamMap);
    console.log('queryParams snapshot: ', this.route.snapshot.queryParams);
    console.log('fragment snapshop: ', this.route.snapshot.fragment);
    this.route.queryParams.subscribe((params) => {
      console.log('observable params: ', params);
      this.allowEdit = params['allowEdit'] == '1';
    });
    this.route.fragment.subscribe((fragment: string) =>
      console.log('observable fragment: ', fragment)
    );

    const id = +this.route.snapshot.params['id'];
    this.server = this.servers11Service.getServer(id);
    this.serverName = this.server.name;
    this.serverStatus = this.server.status;
  }

  onUpdateServer() {
    this.servers11Service.updateServer(this.server.id, {
      name: this.serverName,
      status: this.serverStatus,
    });
    this.changesSaved = true;
    this.router.navigate(['../'], { relativeTo: this.route });
  }

  canDeactivate(
    component: CanComponentDeactivate,
    currentRoute: ActivatedRouteSnapshot,
    currentState: RouterStateSnapshot,
    nextState: RouterStateSnapshot
  ):
    | boolean
    | UrlTree
    | Observable<boolean | UrlTree>
    | Promise<boolean | UrlTree> {
    
    if(!this.allowEdit) {
      return true;
    } 
    if((this.serverName !== this.server.name || this.serverStatus !== this.server.status) && !this.changesSaved) {
      return confirm("Do you want to discard the changes?");
    }
    else{
      return true;
    }
  }

  iCanDeactivate(): boolean {
    return confirm("So funciona pq eles tem o mesmo nome?");
  }
}
