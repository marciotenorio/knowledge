import { Component, OnInit } from '@angular/core';
import { AccountsService } from '../accounts.service';

@Component({
    selector: 'app-root-09-using-services-and-di',
    templateUrl: './root-09-using-services-and-di.component.html',
    providers: [AccountsService]
})

export class Root09UsingServicesAndDiComponent implements OnInit {

  accounts: {name: string, status: string}[] = [];

  constructor(private accountsService: AccountsService) {}

  ngOnInit() {
    this.accounts = this.accountsService.accounts;
  }
}
