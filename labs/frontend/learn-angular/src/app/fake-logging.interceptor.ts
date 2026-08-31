import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpEventType
} from '@angular/common/http';
import { Observable, tap } from 'rxjs';

@Injectable()
export class FakeLoggingInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const modifiedReq = request.clone();
    return next.handle(modifiedReq).pipe(
      tap(event => {
        console.log('LOG - interceptor response', event)
        if(event.type == HttpEventType.Response) {
          console.log('LOG - interceptor of type response', event.body);
        }
      })
    )
  }
}
