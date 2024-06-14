import {
  ActivatedRouteSnapshot,
  CanActivateChildFn,
  CanActivateFn,
  ResolveFn,
  RouterStateSnapshot,
} from '@angular/router';

export const showAlertGuardCanActivateFn: CanActivateFn = (
  route: ActivatedRouteSnapshot,
  state: RouterStateSnapshot
) => {
  return confirm('Testando canActivateFn =)');
};

export const showAlertGuardCanActivateChildFn: CanActivateChildFn = (
  route: ActivatedRouteSnapshot,
  state: RouterStateSnapshot
) => {
  return confirm('Testando canActivateChildFn =)');
};

export const helloResolveFn: ResolveFn<string> = (
 route: ActivatedRouteSnapshot,
 state: RouterStateSnapshot 
) => {
  return "hello";
}
