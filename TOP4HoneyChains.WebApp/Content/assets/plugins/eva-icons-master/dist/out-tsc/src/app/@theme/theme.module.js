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
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.EvaThemeModule = void 0;
var router_1 = require("@angular/router");
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
// components
var footer_component_1 = require("./components/footer/footer.component");
var header_component_1 = require("./components/header/header.component");
var download_icon_component_1 = require("./components/modals/download-icon/download-icon.component");
var page_container_component_1 = require("./components/page-container/page-container.component");
var icon_list_component_1 = require("./components/icon-list/icon-list.component");
var type_switcher_component_1 = require("./components/type-switcher/type-switcher.component");
var animation_switcher_component_1 = require("./components/animation-switcher/animation-switcher.component");
// components
// services
var services_1 = require("./services");
// services
// pipes
var eva_icons_pipe_1 = require("./pipes/eva-icons.pipe");
// pipes
var theme_1 = require("@nebular/theme");
var COMPONENTS = [
    footer_component_1.FooterComponent,
    header_component_1.HeaderComponent,
    download_icon_component_1.DownloadIconComponent,
    page_container_component_1.PageContainerComponent,
    icon_list_component_1.IconListComponent,
    type_switcher_component_1.TypeSwitcherComponent,
    animation_switcher_component_1.AnimationSwitcherComponent,
];
var PIPES = [
    eva_icons_pipe_1.EvaIconsPipe,
];
var EvaThemeModule = /** @class */ (function () {
    function EvaThemeModule() {
    }
    EvaThemeModule_1 = EvaThemeModule;
    EvaThemeModule.forRoot = function () {
        return {
            ngModule: EvaThemeModule_1,
            providers: __spreadArray(__spreadArray(__spreadArray(__spreadArray(__spreadArray([], theme_1.NbThemeModule.forRoot({ name: 'eva' }).providers, true), services_1.evaServices, true), theme_1.NbMenuModule.forRoot().providers, true), theme_1.NbOverlayModule.forRoot().providers, true), theme_1.NbDialogModule.forRoot().providers, true),
        };
    };
    var EvaThemeModule_1;
    EvaThemeModule = EvaThemeModule_1 = __decorate([
        (0, core_1.NgModule)({
            imports: [
                router_1.RouterModule,
                common_1.CommonModule,
                theme_1.NbMenuModule,
                theme_1.NbLayoutModule,
                theme_1.NbCardModule,
                theme_1.NbOverlayModule,
                theme_1.NbDialogModule,
                theme_1.NbCheckboxModule,
                theme_1.NbSpinnerModule,
                theme_1.NbPopoverModule,
                theme_1.NbSelectModule,
            ],
            declarations: __spreadArray(__spreadArray([], COMPONENTS, true), PIPES, true),
            exports: __spreadArray([
                router_1.RouterModule,
                common_1.CommonModule,
                theme_1.NbMenuModule,
                theme_1.NbLayoutModule,
                theme_1.NbCardModule,
                theme_1.NbDialogModule,
                theme_1.NbOverlayModule,
                theme_1.NbCheckboxModule,
                theme_1.NbSpinnerModule,
                theme_1.NbSelectModule,
                footer_component_1.FooterComponent,
                header_component_1.HeaderComponent,
                page_container_component_1.PageContainerComponent,
                icon_list_component_1.IconListComponent
            ], PIPES, true),
            entryComponents: [
                download_icon_component_1.DownloadIconComponent,
            ],
        })
    ], EvaThemeModule);
    return EvaThemeModule;
}());
exports.EvaThemeModule = EvaThemeModule;
//# sourceMappingURL=theme.module.js.map