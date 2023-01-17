import React, { Component, useState, useEffect } from 'react';
import { Link, useHref } from 'react-router-dom';


const List = () => {
    let [flag, setflag] = useState(false);

    const [degrees, setdegrees] = useState([]);

    useEffect(() => {
        fetch("api/qualification/GetQual")
            .then(response => { return response.json(); })
            .then(responseJson => {
                console.log(responseJson);
                setdegrees(responseJson)
            }).catch((err) => {
                console.log("Error In Display", err)
            })
    }, [])
    useEffect(() => {
        fetch("api/qualification/GetQual")
            .then(response => { return response.json(); })
            .then(responseJson => {
                console.log(responseJson);
                setdegrees(responseJson)
            }).catch((err) => {
                console.log("Error In Display", err)
            })
    }, [flag])


    const DeleteQualbyID = (id) => {

        fetch("/api/qualification/DelQual/"+id, {method: 'DELETE'}).then((response) => {
            console.log("Inside DeleteStudent");
            const newQuall = degrees.filter((item) => {
                return (item.id != id);
            });
            setdegrees(newQuall);
            setflag(true);
        }).catch((err) => {
            console.log("Error In Delete", err)
        })
    }

    return (
        <div className="container">

            <h1>Qualification Table</h1>

            <div>
                <div className='col-md-12'>
                    <form> <input type={"text"} className="form-control" style={{ margin: 10 }}></input>
                        <td><button style={{ margin: 10 }} type='button' className='btn btn-primary'>Search</button></td>
                        <td><button style={{ margin: 10 }} type='reset' formAction='/qualification/GetQual' className='btn btn-success'>Reset</button></td>
                    </form>
                </div>
            </div>
            <div className="row">
                <div className='col-sm-3'>
                    <table className="table table-bordered">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Degree</th>
                                {/* <th>Email</th>
              <th>Address</th>
              <th>Phone</th> */}
                                <th colSpan={1}>Operations</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                degrees.map((item) => (
                                    <tr key={item.id}>
                                        <td>{item.id}</td>
                                        <td>{item.degree}</td>
                                        {/* <td>{item.email}</td>
                  <td>{item.address}</td>
                  <td>{item.phone}</td> */}
                                        <td colSpan={2}>
                                            <Link to={"/qualification/editQual"}>
                                                <button type='button' className='btn btn-info'>Edit</button>
                                            </Link>
                                            &nbsp;
                                            {/* <Link to={"/qualification/DelQual/{id}"}> */}
                                            <button type='button' className='btn btn-warning' onClick={() => DeleteQualbyID(item.id)}>Delete</button>
                                            {/* </Link> */}
                                        </td>

                                    </tr>
                                ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>
        </div >

    )
}
export { List };
