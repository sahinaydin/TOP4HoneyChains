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
exports.PageContainerComponent = void 0;
var core_1 = require("@angular/core");
var theme_1 = require("@nebular/theme");
var router_1 = require("@angular/router");
var fromEvent_1 = require("rxjs/internal/observable/fromEvent");
var icon_service_1 = require("../../../@core/data/service/icons/icon.service");
var operators_1 = require("rxjs/operators");
var download_icon_component_1 = require("../modals/download-icon/download-icon.component");
var dialog_state_service_1 = require("../../services/dialog-state.service");
var version_service_1 = require("../../services/version.service");
var analytics_service_1 = require("../../services/analytics.service");
var PageContainerComponent = /** @class */ (function () {
    function PageContainerComponent(iconService, router, activatedRoute, dialogService, breakpointService, themeService, dialogStateService, versionService, analytics) {
        var _this = this;
        this.iconService = iconService;
        this.router = router;
        this.activatedRoute = activatedRoute;
        this.dialogService = dialogService;
        this.breakpointService = breakpointService;
        this.themeService = themeService;
        this.dialogStateService = dialogStateService;
        this.versionService = versionService;
        this.analytics = analytics;
        this.alive = true;
        this.iconsType = 'outline';
        this.isInputFocus = false;
        this.icons = [];
        this.message = '';
        this.breakpoint = { name: '', width: 0 };
        this.animation = 'zoom';
        this.currentVersion = this.versionService.getEvoVersion();
        this.breakpoints = this.breakpointService.getBreakpointsMap();
        this.themeService.onMediaQueryChange()
            .pipe((0, operators_1.takeWhile)(function () { return _this.alive; }))
            .subscribe(function (_a) {
            var oldValue = _a[0], newValue = _a[1];
            _this.breakpoint = newValue;
        });
    }
    PageContainerComponent.prototype.ngAfterViewInit = function () {
        var _this = this;
        this.activatedRoute.queryParams
            .pipe((0, operators_1.takeWhile)(function () { return _this.alive; }), (0, operators_1.delay)(0), (0, operators_1.tap)(function (params) {
            var inputValue = _this.searchInput.nativeElement.value;
            if (!inputValue && params.searchKey) {
                _this.searchInput.nativeElement.value = params.searchKey;
            }
            if (params.type && _this.iconsType !== params.type) {
                _this.iconsType = params.type;
            }
        }), (0, operators_1.mergeMap)(function (params) {
            return params.searchKey && params.type ?
                _this.iconService.getFilteredIconsData(params.searchKey, params.type) :
                _this.iconService.getIconsData(_this.iconsType);
        }))
            .subscribe(function (iconsData) {
            _this.icons = iconsData.icons;
            _this.message = iconsData.message;
        });
        (0, fromEvent_1.fromEvent)(this.searchInput.nativeElement, 'keyup')
            .pipe((0, operators_1.takeWhile)(function () { return _this.alive; }), (0, operators_1.debounceTime)(500))
            .subscribe(function (event) {
            var searchKeyValue = event.target.value;
            if (searchKeyValue) {
                _this.updateQueryParams({ searchKey: searchKeyValue, type: _this.iconsType });
            }
            else {
                var url = _this.router.url.substring(0, _this.router.url.indexOf('?'));
                _this.router.navigateByUrl(url);
            }
        });
    };
    Object.defineProperty(PageContainerComponent.prototype, "placeholder", {
        get: function () {
            return this.isLoading || this.noSearchResults ? '' : "Search ".concat(this.icons.length, " Icons");
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(PageContainerComponent.prototype, "noSearchResults", {
        get: function () {
            return (this.message &&
                this.icons.length === 0);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(PageContainerComponent.prototype, "isLoading", {
        get: function () {
            return (!this.message &&
                this.icons.length === 0);
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(PageContainerComponent.prototype, "isMobileMode", {
        get: function () {
            return this.breakpoint.width <= this.breakpoints.sm;
        },
        enumerable: false,
        configurable: true
    });
    PageContainerComponent.prototype.clickIcon = function (icon) {
        var _this = this;
        this.analytics.trackEvent('openIconDialog', icon);
        if (this.isMobileMode) {
            return;
        }
        var modalRef = this.dialogService.open(download_icon_component_1.DownloadIconComponent, {
            backdropClass: 'download-icon',
        });
        var componentInstance = modalRef.componentRef.instance;
        componentInstance.selectedIcon = icon;
        componentInstance.iconType = this.iconsType;
        this.dialogStateService.changeDialogState('open');
        modalRef.onClose
            .subscribe(function () {
            _this.dialogStateService.changeDialogState('close');
        });
    };
    PageContainerComponent.prototype.handleFocusInput = function () {
        this.isInputFocus = true;
    };
    PageContainerComponent.prototype.handleBlurInput = function () {
        this.isInputFocus = false;
    };
    PageContainerComponent.prototype.changeAnimation = function (animationType) {
        this.animation = animationType;
    };
    PageContainerComponent.prototype.changeIconsType = function (iconsType) {
        this.iconsType = iconsType;
        this.icons = [];
        this.updateQueryParams({ type: iconsType });
    };
    PageContainerComponent.prototype.updateQueryParams = function (queryParams) {
        this.router.navigate([], {
            relativeTo: this.activatedRoute,
            queryParamsHandling: 'merge',
            queryParams: queryParams,
        });
    };
    PageContainerComponent.prototype.ngOnDestroy = function () {
        this.alive = false;
    };
    var _a, _b, _c, _d, _e, _f, _g;
    __decorate([
        (0, core_1.ViewChild)('searchInput'),
        __metadata("design:type", typeof (_f = typeof core_1.ElementRef !== "undefined" && core_1.ElementRef) === "function" ? _f : Object)
    ], PageContainerComponent.prototype, "searchInput", void 0);
    __decorate([
        (0, core_1.ViewChild)('iconsBlock'),
        __metadata("design:type", typeof (_g = typeof core_1.ElementRef !== "undefined" && core_1.ElementRef) === "function" ? _g : Object)
    ], PageContainerComponent.prototype, "iconsElement", void 0);
    PageContainerComponent = __decorate([
        (0, core_1.Component)({
            selector: 'eva-page-container',
            templateUrl: 'page-container.component.html',
            styleUrls: ['page-container.component.scss'],
        }),
        __metadata("design:paramtypes", [icon_service_1.IconService, typeof (_a = typeof router_1.Router !== "undefined" && router_1.Router) === "function" ? _a : Object, typeof (_b = typeof router_1.ActivatedRoute !== "undefined" && router_1.ActivatedRoute) === "function" ? _b : Object, typeof (_c = typeof theme_1.NbDialogService !== "undefined" && theme_1.NbDialogService) === "function" ? _c : Object, typeof (_d = typeof theme_1.NbMediaBreakpointsService !== "undefined" && theme_1.NbMediaBreakpointsService) === "function" ? _d : Object, typeof (_e = typeof theme_1.NbThemeService !== "undefined" && theme_1.NbThemeService) === "function" ? _e : Object, dialog_state_service_1.DialogStateService,
            version_service_1.EvaVersionService,
            analytics_service_1.EvaAnalytics])
    ], PageContainerComponent);
    return PageContainerComponent;
}());
exports.PageContainerComponent = PageContainerComponent;
//# sourceMappingURL=page-container.component.js.map