import { HttpInterceptorFn } from '@angular/common/http';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  //need to migrate to fn based
  console.log('fn interceptor')
  return next(req);
};
