import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProjectComponent } from './project/project.component';
import { ModulesComponent } from './modules/modules.component';
import { BugsComponent } from './bugs/bugs.component';
import { AuthGuard } from './_guards/auth.guard';
import { AdminGuard } from './_guards/admin.guard';
import { UserComponent } from './user/user.component';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        canActivate: [AuthGuard, AdminGuard],
        children: [
            { path: 'project', component: ProjectComponent },
            { path: 'modules', component: ModulesComponent },
            { path: 'user', component: UserComponent}
        ]
    },
    { path: 'bugs', component: BugsComponent, canActivate: [AuthGuard] },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
