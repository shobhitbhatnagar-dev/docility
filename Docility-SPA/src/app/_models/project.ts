import { Module } from './Module';


export interface Project {
    id: number;
    projectName: string;
    createdOn: Date;
    modules?: Module[];
    isActive: boolean;
}
