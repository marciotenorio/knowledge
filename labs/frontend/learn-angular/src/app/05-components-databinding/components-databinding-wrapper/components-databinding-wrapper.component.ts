import { Component } from '@angular/core';

@Component({
  selector: 'app-components-databinding-wrapper',
  templateUrl: './components-databinding-wrapper.component.html',
  styleUrl: './components-databinding-wrapper.component.css'
})
export class ComponentsDatabindingWrapperComponent {
  serverElements = [{type: 'server', content: 'Just a test!', name: 'TestServer'}];

  onServerAdded(serverData: {serverName: string, serverContent: string}) {

    this.serverElements.push({
      type: 'server',
      name: serverData.serverName,
      content: serverData.serverContent
    });
  }

  onBlueprintAdded(blueprintData: {serverName: string, serverContent: string}) {
    this.serverElements.push({
      type: 'blueprint',
      name: blueprintData.serverName,
      content: blueprintData.serverContent
    });
  }

  onChangeFirst() {
    this.serverElements[0].name = 'Changed!';
  }

  onDestroyFirst() {
    this.serverElements.splice(0, 1);
  }
}
