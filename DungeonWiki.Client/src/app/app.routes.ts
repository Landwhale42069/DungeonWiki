import { Routes } from '@angular/router';
import { BeansComponent } from './beans/beans.component';

export const routes: Routes = [
    {path: "beans/:param", component: BeansComponent}
];
