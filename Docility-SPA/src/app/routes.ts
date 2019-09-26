import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProjectComponent } from './project/project.component';
import { ModulesComponent } from './modules/modules.component';
import { BugsComponent } from './bugs/bugs.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        canActivate: [AuthGuard],
        children: [
            { path: 'project', component: ProjectComponent },
            { path: 'modules', component: ModulesComponent },
            { path: 'bugs', component: BugsComponent },
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
