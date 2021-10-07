import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EqquipmentCategory } from './EqquipmentCategory';
import { Equipment } from './Equipment';
import { HomePageItemView } from './HomePageItemView';
import { Activity } from './Activity';
import { activitySort } from './activitySort';
@Injectable({
  providedIn: 'root'
})
export class EquipmentservicesService {
  Home_page_eq_by_category: Array<HomePageItemView> | undefined;
  url: string = '';
  Activitylst: Array<Activity>; //| undefined;
  needActivitylst: Array<Activity>;
  myarray: Array<activitySort>;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { this.url = baseUrl }

  EquipmentCategoryList: Array<EqquipmentCategory> = [
    { catid: 1, catname: 'Wheel Loader' },
    { catid: 2, catname: 'Mobile Crane' },
    { catid: 3, catname: 'Crawler Crane' },
    { catid: 4, catname: 'Skid LOader' }
  ];
  Equipmentlist: Array<Equipment> = [
    { eqid: 1, eqtype: 'caterpiller', catid: 1, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 2, eqtype: 'Liebherr', catid: 2, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '70 ton' },
    { eqid: 3, eqtype: 'TEREX', catid: 3, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '45 ton' },
    { eqid: 4, eqtype: 'MAN', catid: 4, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 5, eqtype: 'MERCEDES', catid: 5, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 6, eqtype: 'caterpiller', catid: 1, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 7, eqtype: 'LIEBHERR', catid: 2, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 8, eqtype: 'MAN', catid: 4, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 9, eqtype: 'KOMATSU', catid: 5, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' },
    { eqid: 10, eqtype: 'caterpiller', catid: 1, eqserialno: '52tyrt', eqyearmanf: 2018, eqmodel: 'cat950f', eqcapacity: '--' }
  ];
  HomepageList: Array<HomePageItemView>;
  Filtered_Eq_by_category(cat_type: string) {
    if (cat_type === 'All Equipments') {
      this.Home_page_eq_by_category = [];
      this.Home_page_eq_by_category = this.HomepageList
    } else {
      this.Home_page_eq_by_category = [];
      this.Home_page_eq_by_category = this.HomepageList.filter(a => a.categoryName === cat_type)
    }
  }
  GetItesmsDataFromAPI() {
    this.http.get(this.url + 'api/HomepageApi').toPromise().then(
      res => {
        this.HomepageList = res as HomePageItemView[];
        this.Home_page_eq_by_category = res as HomePageItemView[];
      })
    this.http.get(this.url + 'api/ActionStateApi').toPromise().then(
      res => {
        this.Activitylst = res as Activity[];        
        ////////////////////////////
        this.needActivitylst = this.Activitylst.filter(a => a.mintenanceState === 1);
        this.myarray = [];
        for (let i = 0; i < this.needActivitylst.length; i++) {
          if (this.myarray.length === 0) {
            let myobj = {
              equipmentId: this.needActivitylst[i].equipmentId,
              equipmentName: this.needActivitylst[i].equipmentName
            }
            this.myarray.push(myobj);
          }
          if (i > 0) {
            if (this.needActivitylst[i].equipmentId != this.needActivitylst[i - 1].equipmentId) {
              let myobj = {
                equipmentId: this.needActivitylst[i].equipmentId,
                equipmentName: this.needActivitylst[i].equipmentName
              }
              this.myarray.push(myobj);
            }
          }
        }
        //////////////////////////
      })












  }
}
