export const LOGIN='Login';
export const SIGNUP='Signup';
export const MAIN='Main';

export function go_login(){
    return{
        type:LOGIN
    }
}
export function go_signup(){
    return{
        type:SIGNUP
    }
}
export function go_main(id,username,type,token){
    return{
        type:MAIN,
        payload:{id:id,username:username,type:type,token:token}
    }
}