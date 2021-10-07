export class Equipment{
    constructor(public  eqid:number, public  eqtype:string,public catid:number, public eqserialno:string,public eqyearmanf:number, public eqmodel:string,public eqcapacity:string)     
    {
        this.eqid=eqid;
        this.eqtype=eqtype;
        this.catid=catid;
        this.eqserialno=eqserialno;
        this.eqyearmanf=eqyearmanf;
        this.eqmodel=eqmodel;
        this.eqcapacity=eqcapacity;
    }
}

