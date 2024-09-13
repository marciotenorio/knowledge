import { Root13UnderstandingObservablesComponent } from "./root-13-understanding-observables/root-13-understanding-observables.component";
import { ObservablesCheckComponent } from "./observables-check/observables-check.component";
import { Routes } from "@angular/router";
import { ObsSubBehComponent } from "./obs-sub-beh/obs-sub-beh.component";

export const USING_UNDERSTANDING_OBSERVABLES = [
    Root13UnderstandingObservablesComponent,
    ObservablesCheckComponent,
    ObsSubBehComponent
];

export const ROUTES_UNDERSTANDING_OBSERVABLES: Routes = [
    {
        path: '',
        component: ObsSubBehComponent, 
    },
    {
        path: 'observables',
        component: ObservablesCheckComponent
    }
];