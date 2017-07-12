import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';

import { UserTableComponent } from './user-table.component';
import { VizionDemoRoutingModule } from './viziondemo-routing.module';

@NgModule({
  imports: [
    VizionDemoRoutingModule,
    CommonModule,
    HttpModule
  ],
  declarations: [
    UserTableComponent
  ],
  providers: [],
})
export class VizionDemoModule { }
