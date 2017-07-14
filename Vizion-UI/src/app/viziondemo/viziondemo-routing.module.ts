import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserTableComponent } from './user-table.component';
import { AppointmentTableComponent } from './appointment.component';
import { CarrierTableComponent } from './carrier.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Vizion Demo'
    },
    children: [
      {
        path: 'user-table',
        component: UserTableComponent,
        data: {
          title: 'Users'
        }
      },
      {
        path: 'appointment-table',
        component: AppointmentTableComponent,
        data: {
          title: 'Appointments'
        }
      },
      {
        path: 'carrier-table',
        component: CarrierTableComponent,
        data: {
          title: 'Carriers'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VizionDemoRoutingModule {}
