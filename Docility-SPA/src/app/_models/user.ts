import { Workgroup } from './workgroup';

export interface User {
    id: number;
    username: string;
    emailId: string;
    role: string;
    createdOn: Date;
    workgroup?: Workgroup[];

}
