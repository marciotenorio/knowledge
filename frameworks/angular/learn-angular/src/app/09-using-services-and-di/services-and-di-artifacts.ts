import { AccountComponent } from "./account/account.component";
import { AccountsService } from "./accounts.service";
import { LoggingService } from "./logging.service";
import { NewAccountComponent } from "./new-account/new-account.component";
import { Root09UsingServicesAndDiComponent } from "./root-09-using-services-and-di/root-09-using-services-and-di.component";

export const USING_SERVICES_AND_DI_ARTIFACTS = [
    Root09UsingServicesAndDiComponent,
    AccountComponent,
    NewAccountComponent
];

export const INJECTING_SERVICES_AND_DI_ARTIFACTS = [
    LoggingService,
    AccountsService
];
