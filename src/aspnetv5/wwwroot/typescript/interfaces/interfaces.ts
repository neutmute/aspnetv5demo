module TypeScriptDemoApp.Models {

    export interface IAddress {
        street: string;
        suburb: string;
        state: string;
        postcode: string;
    }

    export interface IPerson {
        firstName: string;
        lastName: string;
        email: string;
        address: IAddress;
    }

    //export class Person implements IPerson {

    //    firstName: string;
    //    lastName: string;
    //    email: string;
    //    address: IAddress;

    //    getTitle(): string {
    //        return "Mr";
    //    }
    //}

    //export class Knight extends Person{
    //    getTitle(): string {
    //        return "Sir";
    //    }
    //}

}