import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BsDropdownModule } from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProjectComponent } from './project/project.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './nav/nav.component';
import { FormsModule} from '@angular/forms';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ValuesService } from './_services/values.service';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AlertifyService } from './_services/alertify.service';
import { ModulesComponent } from './modules/modules.component';
import { BugsComponent } from './bugs/bugs.component';
import { appRoutes } from './routes';
import { AuthGuard } from './_guards/auth.guard';
import { AdminGuard } from './_guards/admin.guard';
import { DeveloperGuard } from './_guards/developer.guard';
import { TesterGuard } from './_guards/tester.guard';
import { UserService } from './_services/user.service';
import { UserComponent } from './user/user.component';
import { ProjectService } from './_services/project.service';
import { ModuleService } from './_services/module.service';



@NgModule({
   declarations: [
      AppComponent,
      ProjectComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      ModulesComponent,
      BugsComponent,
      UserComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      ValuesService,
      AlertifyService,
      AuthGuard,
      AdminGuard,
      DeveloperGuard,
      TesterGuard,
      UserService,
      ProjectService,
      ModuleService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
