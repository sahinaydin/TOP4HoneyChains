"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.AppComponent = void 0;
var core_1 = require("@angular/core");
var dialog_state_service_1 = require("./@theme/services/dialog-state.service");
var AppComponent = /** @class */ (function () {
    function AppComponent(dialogStateService) {
        var _this = this;
        this.dialogStateService = dialogStateService;
        this.isOpenDialog = false;
        this.dialogStateService.onChangeDialogState()
            .subscribe(function (_a) {
            var state = _a.state;
            _this.isOpenDialog = state === 'open';
        });
    }
    AppComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-app',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.scss'],
        }),
        __metadata("design:paramtypes", [dialog_state_service_1.DialogStateService])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map