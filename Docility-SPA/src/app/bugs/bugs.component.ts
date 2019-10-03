import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';
import { BugService } from '../_services/bug.service';
import { Bug } from '../_models/bug';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-bugs',
  templateUrl: './bugs.component.html',
  styleUrls: ['./bugs.component.css']
})
export class BugsComponent implements OnInit {
  bugs: any;
  bug: any;
  viewBug: boolean ;

  constructor(
    private http: HttpClient,
    private alert: AlertifyService,
    private BugServices: BugService
  ) {}

  ngOnInit() {
    this.loadBugs();
    this.viewBug = false;
  }

  loadBugs() {
    this.BugServices.getBugs().subscribe(
      (Bugs: Bug[]) => {
        this.bugs = Bugs;
      },
      error => {
        this.alert.error(error);
      }
    );
  }

  backToBugs() {
    this.viewBug = false;
  }

  getBug(id: number) {
    this.BugServices.getBug(id).subscribe(
      (B: Bug) => {
        this.bug = B;
        this.viewBug = true;
      },
      error => {
        this.alert.error(error);
      }, () => {
        if ( this.bug) {
          this.viewBug = true;
        }
      }
    );
  }
}
