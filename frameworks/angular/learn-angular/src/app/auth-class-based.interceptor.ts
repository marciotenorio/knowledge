import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpHeaders
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthClassBasedInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    console.log('interceptor class-based')
    // const modifiedReq = request.clone({ url: request.url + 'oi' });
    const modifiedReq = request.clone({ headers: new HttpHeaders({ 'Fake-Auth': 'Tony' }) });
    return next.handle(modifiedReq);
  }
}
