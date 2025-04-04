import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { AuthService } from '../auth/services/auth.service';

export const authInterceptor: HttpInterceptorFn = (req, next) => {

  const auth = inject(AuthService)

  if (req.url.includes('cart') || req.url.includes('orders') || req.url.includes('wishlist')) {
    req = req.clone({
      setHeaders: {
        token: auth.getToken()!
      }
    })
  }

  return next(req);
};
