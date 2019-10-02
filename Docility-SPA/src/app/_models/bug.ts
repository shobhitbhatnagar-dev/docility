import { Workgroup } from './workgroup';
import { Attachment } from './Attachment';
import { Communication } from './communication';

export interface Bug {
    id: number;
    title: string;
    projectId: number;
    projectName: string;
    moduleId: number;
    moduleName: number;
    priorityId: number;
    priority: string;
    categoryId: number;
    category: string;
    reproducibilityId: number;
    reproducibility: string;
    expectedResults: string;
    description: string;
    statusId: number;
    status: string;
    reportedBy: number;
    reportedByName: string;
    reportedOn: Date;
    assignedTo?: number;
    assignedToName?: string;
    assignedOn: Date;
    closingRemark?: string;
    closedOn?: Date;
    workgroup?: Workgroup;
    communications?: Communication[];
    attachments?: Attachment[];
}
