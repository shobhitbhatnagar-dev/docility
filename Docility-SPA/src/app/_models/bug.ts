import { Workgroup } from './workgroup';
import { Attachment } from './Attachment';
import { Project } from './project';
import { Module } from './Module';

export interface Bug {
    id: number;
    title: string;
    project: Project;
    module: Module;
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
    assignedOn?: Date;
    closingRemark?: string;
    closedOn?: Date;
    workgroup?: Workgroup;
    attachments?: Attachment[];
}
