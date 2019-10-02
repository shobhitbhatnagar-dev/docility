import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Module } from '../_models/Module';
import { ModuleService } from '../_services/module.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-modules',
  templateUrl: './modules.component.html',
  styleUrls: ['./modules.component.css']
})
export class ModulesComponent implements OnInit {
  modules: any;
  constructor(
    private http: HttpClient,
    private alertify: AlertifyService,
    private moduleService: ModuleService
  ) {}

  ngOnInit() {
    this.loadModules();
  }
  loadModules() {
    this.moduleService.getModules().subscribe(
      (modules: Module[]) => {
        this.modules = modules;
      },
      error => {
        this.alertify.error(error);
      }
    );
  }
}
