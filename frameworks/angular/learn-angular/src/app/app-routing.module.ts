import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ROUTES_CHPT_11 } from './11-changing-pages-with-routing/changing-pages-with-routing-artifacts';

@NgModule({
  //Recebe e configura com nossas rotas
  imports: [RouterModule.forRoot([...ROUTES_CHPT_11], { useHash: false})], //Da pra usar hashMode /#/
  //Exporta com nossas rotas configuradas
  exports: [RouterModule]
})
export class AppRoutingModule { }
