export class Shipment {
  Id: number;
  ShipmentId: string;
  Consolidation: number;
  Customer: string;
  AppointmentDate: Date;
  ArrivalDate: Date;
  ShipDate: Date;
  FullPallets: number;
  PickPakllets: number;
  TotalPallets: number;
  Dock: string;
}
