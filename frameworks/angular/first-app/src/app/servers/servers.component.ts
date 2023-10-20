import { Component } from '@angular/core';

@Component({
  /**
   * All possibilities for selector property.
   */
  selector: 'app-servers', //css element selector
  // selector: '[app-servers]', css attribute selector
  // selector: '.app-servers', css class selector
  // template: '<app-server></app-server><app-server></app-server>',
  templateUrl: './servers.component.html',
  /**
   * Can have multiple external css files
   */
  // styleUrls: ['./servers.component.css']
  /**
   * Inline styles like template above
   */
  // styles: [`
  //     h3 {
  //       color: red;
  //     }
  
  // `,
  // `
  //     p {
  //       color: yellow;
  //     }
  // `]
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {

  allowNewServer = true;
  serverCreationStatus = 'No server was created!';
  serverName = 'No name';
  serverCreated = false;
  servers = ['Test Server', 'Test Server 2']

  constructor() {
    setTimeout(() => {
      this.allowNewServer = !this.allowNewServer;
    }, 2000)
  }

  onServerCreated(event){
    this.servers.push(this.serverName);
    this.serverCreated = true;
    this.serverCreationStatus = 'Server was created! Name is' + this.serverName ;
  }

  onUpdateServerName(event: Event) {
    this.serverName = (event.target as HTMLInputElement).value;
  }

}
