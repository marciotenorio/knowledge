import { Component } from '@angular/core';

@Component({
  selector: 'app-root-17-pipes',
  templateUrl: './root-17-pipes.component.html',
  styleUrl: './root-17-pipes.component.css'
})
export class Root17PipesComponent {
  appStatus = new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve('stable')
    }, 2000)
  });
  filteredStatus = '';
  servers = [
    {
      instanceType: 'medium',
      name: 'Production Server',
      status: 'stable',
      started: new Date(15, 1, 2017)
    },
    {
      instanceType: 'large',
      name: 'User Database',
      status: 'stable',
      started: new Date(15, 1, 2017)
    },
    {
      instanceType: 'small',
      name: 'Development Server',
      status: 'offline',
      started: new Date(15, 1, 2017)
    },
    {
      instanceType: 'small',
      name: 'Testing Environment Server',
      status: 'stable',
      started: new Date(15, 1, 2017)
    }
  ];
  getStatusClasses(server: {instanceType: string, name: string, status: string, started: Date}) {
    return {
      'list-group-item-success': server.status === 'stable',
      'list-group-item-warning': server.status === 'offline',
      'list-group-item-danger': server.status === 'critical'
    };
  }

  onAddServer() {
    const rdn = Math.floor(Math.random() * 10);

    this.servers.push({
      instanceType: rdn % 2 == 0 ? 'small' : 'large',
      name: `New Server - ${rdn}`,
      status: rdn % 2 !== 0 ? 'stable' : 'offline',
      started: new Date(15, 1, 2017)
    });
  }
}
