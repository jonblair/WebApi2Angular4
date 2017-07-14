import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { UserTableComponent } from './user-table.component';
import { AppointmentTableComponent } from './appointment.component';
import { CarrierTableComponent } from './carrier.component';

import { VizionDemoRoutingModule } from './viziondemo-routing.module';

@NgModule({
  imports: [
    VizionDemoRoutingModule,
    CommonModule,
    HttpModule,
    FormsModule
  ],
  declarations: [
    UserTableComponent,
    AppointmentTableComponent,
    CarrierTableComponent
  ],
  providers: [],
})
export class VizionDemoModule { }
