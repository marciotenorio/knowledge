import { Routes } from "@angular/router";
import { AuthGuard } from "./auth-guard.service";
import { AuthService } from "./auth.service";
import { NotFoundComponent } from "../not-found/not-found.component";
import { Home11Component } from "./home-11/home-11.component";
import { Root11ChangingPagesWithRoutingComponent } from "./root-11-changing-pages-with-routing/root-11-changing-pages-with-routing.component";
import { EditServer11Component } from "./servers-11/edit-server-11/edit-server-11.component";
import { Server11Component } from "./servers-11/server-11/server-11.component";
import { Servers11Component } from "./servers-11/servers-11.component";
import { Servers11Service } from "./servers-11/servers-11.service";
import { User11Component } from "./users-11/user-11/user-11.component";
import { Users11Component } from "./users-11/users-11.component";
import { CanDeactivateGuard } from "./servers-11/edit-server-11/can-deactivate.service";
import { ErrorPage11Component } from "./error-page/error-page-11.component";
import { ServerResolver } from "./servers-11/server-11/server-resolver.service";
import { helloResolveFn, showAlertGuardCanActivateChildFn, showAlertGuardCanActivateFn } from "./guards-functional";

export const USING_CHANGING_PAGES_WITH_ROUTING = [
    Root11ChangingPagesWithRoutingComponent,
    Home11Component,
    Servers11Component,
    Server11Component,
    EditServer11Component,
    Users11Component,
    User11Component
];

export const INJECTING_CHANGING_PAGES_WITH_ROUTING = [
    Servers11Service,
    AuthGuard,
    AuthService,
    CanDeactivateGuard,
    ServerResolver
];

export const ROUTES_CHPT_11: Routes = [
  {path: '', component: Home11Component},
  {
    path: 'users', component: Users11Component, canActivateChild: [showAlertGuardCanActivateChildFn],
    children: [
      {path: ':id/:name', component: User11Component, resolve: { hello: helloResolveFn }},
    ]
  },
  {
    path: 'servers', 
    // canActivate: [AuthGuard], 
    canActivateChild: [AuthGuard],
    component: Servers11Component, 
    children: [
      {path: ':id', component: Server11Component, resolve: { server: ServerResolver }},
      {path: ':id/edit', component: EditServer11Component, canDeactivate: [CanDeactivateGuard]}
    ]
  },
  // {path: 'not-found', component: NotFoundComponent},
  {
    path: 'not-found', component: ErrorPage11Component, data: { message: 'Page not found!' }, 
    canActivate: [showAlertGuardCanActivateFn],
    canDeactivate: [(component: ErrorPage11Component) => confirm("Using canDeactivateFn inline =)")]
  },
  {path: '**', redirectTo: '/not-found'}
];