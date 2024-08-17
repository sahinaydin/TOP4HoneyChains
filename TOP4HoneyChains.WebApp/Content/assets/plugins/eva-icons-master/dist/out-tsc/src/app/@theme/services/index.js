"use strict";
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
Object.defineProperty(exports, "__esModule", { value: true });
exports.evaServices = void 0;
var version_service_1 = require("./version.service");
var dialog_state_service_1 = require("./dialog-state.service");
var analytics_service_1 = require("./analytics.service");
exports.evaServices = [
    version_service_1.EvaVersionService,
    dialog_state_service_1.DialogStateService,
    analytics_service_1.EvaAnalytics,
];
//# sourceMappingURL=index.js.map