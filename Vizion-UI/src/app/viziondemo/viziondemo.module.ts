import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts/ng2-charts';

import { UserTableComponent } from './user-table.component';
import { AppointmentTableComponent } from './appointment.component';
import { CarrierTableComponent } from './carrier.component';
import { ShipmentTableComponent } from './shipment.component';
import { InventoryMetricsComponent } from './inventory.component';

import { VizionDemoRoutingModule } from './viziondemo-routing.module';

@NgModule({
  imports: [
    VizionDemoRoutingModule,
    CommonModule,
    HttpModule,
    FormsModule,
    ChartsModule
  ],
  declarations: [
    UserTableComponent,
    AppointmentTableComponent,
    CarrierTableComponent,
    ShipmentTableComponent,
    InventoryMetricsComponent
  ],
  providers: [],
})
export class VizionDemoModule { }
