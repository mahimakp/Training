import {HomeComponent} from './HomeApp.HomeComponent'
import {IndexComponent} from './HomeApp.IndexComponent'
import {LoginComponent} from './HomeApp.LoginComponent'
import {MasterPageComponent} from './HomeApp.MasterPageComponent'
import {MyAuthGuard} from '../Security/Security.AuthGuard'
 
export const HomeRoutes = [
    {path : '', component : MasterPageComponent, canActivate : [MyAuthGuard]},
    {path : 'Login', component : LoginComponent},
    {path : 'Home', component : HomeComponent,canActivate : [MyAuthGuard]},
    {path : 'Master', component : MasterPageComponent, canActivate : [MyAuthGuard]},
    {path : 'Patient', loadChildren : () => import('../PatientApp/PatientApp.PatientAddModule')
    .then(m => m.PatientAddModule),canActivate : [MyAuthGuard]},
    
]