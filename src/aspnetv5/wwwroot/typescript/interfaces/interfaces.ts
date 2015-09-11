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
}