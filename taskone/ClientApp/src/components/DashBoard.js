import React, { Component } from 'react';
import { Form, Button, Table } from 'react-bootstrap';
import toastr from 'toastr';

class DashBoard extends Component {

    constructor(props) {
        super(props);

        this.state = {
            pageNumber: 0,
            pageSize: 0,
            listUser: [],
            message: '',
            isFinishedData: false
        }
    }

    async componentDidMount() {

        const response = await fetch('api/Values/GetCountUsers');
        const data = await response.json();
        console.log('resp', data);
        this.setState({ pageSize: data.payload });

        const res = await fetch(`api/Values/GetUsersPhoneNumber?pageNumber=${this.state.pageNumber}`);
        const datas = await res.json();
        this.setState({ listUser: datas.payload });

    }


    sendMessage = async () => {
        if (this.state.message != '') {

            let listUasers = this.state.listUser.map(x => {
                return x.id;
            })

            listUasers = listUasers.toString();

            const requestOptions = {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                //body: JSON.stringify({ listUsermessage: listUasers})
            };
            await fetch(`api/Values/SendSMSMessage?message=${this.state.message}&listUsermessage=${listUasers}`, requestOptions)
                .then(response => response.json())
                .then(data => this.setState({ postId: data.id }));

            toastr.success('Send Message Success');
            this.NextUser();
        } else {
            toastr.error('Please Write Message');
        }
    }

    PreUsers = async () => {
        let pageNumber = this.state.pageNumber;
        pageNumber = pageNumber - 1;
        const res = await fetch(`api/Values/GetUsersPhoneNumber?pageNumber=${pageNumber}`);
        const datas = await res.json();

        this.setState({ listUser: datas.payload, pageNumber: (this.state.pageNumber - 1), isFinishedData: false });
    }

    NextUser = async () => {
        let pageNumber = this.state.pageNumber;
        pageNumber = pageNumber + 1;
        const res = await fetch(`api/Values/GetUsersPhoneNumber?pageNumber=${pageNumber}`);
        const datas = await res.json();

        if (datas.payload.length > 0) {
            this.setState({ listUser: datas.payload, pageNumber: (this.state.pageNumber + 1) });
        } else {
            this.setState({ isFinishedData: true });
        }
    }

    render() {
        return (
            <div>
                <Form>
                    <Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
                        <Form.Label>Message</Form.Label>
                        <Form.Control as="textarea" rows={3} onChange={e => this.setState({
                            message: e.target.value
                        })} />
                    </Form.Group>
                    <Button variant="primary" type="button" onClick={this.sendMessage}>
                        Submit
                    </Button>
                </Form>
                <Button disabled={this.state.pageNumber == 0} onClick={this.PreUsers}>Pre</Button>
                <Button disabled={this.state.isFinishedData == true} onClick={this.NextUser}>Next</Button>
                <Table striped bordered hover>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Phone</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.listUser.length > 0 ?
                            this.state.listUser.map((x, i) => {
                                return (
                                    <tr key={i}>
                                        <td>{x.name}</td>
                                        <td>{x.phoneNumber}</td>
                                    </tr>);
                            })
                            : null}
                    </tbody>
                </Table>
            </div>
        )
    }

}


export default DashBoard;