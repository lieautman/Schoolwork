import React, { Component } from 'react'

class RobotForm extends Component {
	constructor(){
		super()
        this.name=''
        this.type=''
        this.mass=0



        this.onAdd=function(){
            let {store}=this.props
            let robot={
                name:this.name,
                type:this.type,
                mass:this.mass
            }
            store.addRobot(robot);
        }
	}



	render() {
		return (
			<div>
                <h3>This is the form for robots:</h3>
                <input type='text' placeholder='name' onChange={(evt)=>this.name=evt.target.value}></input>
                <input type='text' placeholder='type' onChange={(evt)=>this.type=evt.target.value}></input>
                <input type='text' placeholder='mass' onChange={(evt)=>this.mass=evt.target.value}></input>
                <input type='button' value='add' onClick={()=>{this.onAdd()}}></input>
			</div>
		)
	}
}

export default RobotForm