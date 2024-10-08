import { Component, Input } from '@angular/core';
import { LoggingService } from '../logging.service';
import { AccountsService } from '../accounts.service';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
  //providers: [LoggingService] //AccountsService removed from here to get the parent instance
})
export class AccountComponent {
  @Input() account: {name: string, status: string};
  @Input() id: number;

  constructor(private loggingService: LoggingService, 
    private accountsService: AccountsService
  ) {}

  onSetTo(status: string) {
    this.accountsService.updateAccount(this.id, status);
  }
}
