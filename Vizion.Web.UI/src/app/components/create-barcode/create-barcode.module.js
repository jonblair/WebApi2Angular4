"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
// Angular Imports
var core_1 = require("@angular/core");
// This Module's Components
var create_barcode_component_1 = require("./create-barcode.component");
var CreateBarcodeModule = (function () {
    function CreateBarcodeModule() {
    }
    return CreateBarcodeModule;
}());
CreateBarcodeModule = __decorate([
    core_1.NgModule({
        imports: [],
        declarations: [
            create_barcode_component_1.CreateBarcodeComponent,
        ],
        exports: [
            create_barcode_component_1.CreateBarcodeComponent,
        ]
    })
], CreateBarcodeModule);
exports.CreateBarcodeModule = CreateBarcodeModule;
//# sourceMappingURL=create-barcode.module.js.map