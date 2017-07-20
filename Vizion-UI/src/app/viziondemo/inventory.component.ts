import { forEach } from '@angular/router/src/utils/collection';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { InventoryPalletMetric } from './../models/inventorypalletmetric';
import { InventoryMetricApiService } from './../_services/inventory-metrics.service';

@Component({
  templateUrl: 'inventory.component.html',
  providers: [InventoryMetricApiService]
})
export class InventoryMetricsComponent implements OnInit {
  errorMessage: string;
  public metrics: InventoryPalletMetric[] = [];
  public pieChartLabels: string[] = ['KEYMC', 'CONAGRA', 'PILGRIMS',
  'LEWIS', 'PERDUE', 'RICH', 'TENNVA', 'VIEACQ'];
  public pieChartData: number[] = [1233, 2599, 1690,
  521, 1724, 8393, 680, 441];
  public pieChartType: string = 'pie';

  // events
  public chartClicked(e: any): void {
    console.log(e);
  }

  public chartHovered(e: any): void {
    console.log(e);
  }

  constructor(private myInventoryMetricApiService: InventoryMetricApiService,
                private _router: Router) { }
  ngOnInit() {
      //   this.myInventoryMetricApiService.getInventoryPalletMetrics()
      //  .subscribe(
      //       value => {this.metrics = value; },
      //       error => this.errorMessage = <any>error);
    }
}
