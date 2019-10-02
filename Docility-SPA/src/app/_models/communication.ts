import { User } from './user';
import { Workgroup } from './workgroup';

export interface Communication {
    id: number;
    message: string;
    user?: User;
    userId: number;
    bugId: number;
    isPrivate: boolean;
    workgroup?: Workgroup;
    timeStamp: Date;
}
