using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更新出战角色及魂共鸣技能 message
 */
public class ReqUpdateBattleFighterInfoMessage : Message 
{
	//出战角色id
	List<int> _characterIds = new List<int>();
	//魂共鸣id
	List<int> _soulResonanceIds = new List<int>();
    //书院技能书编号
    List<int> _collegeBookIdList = new List<int>();
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//出战角色id
		SerializeUtils.WriteShort(stream, (short)_characterIds.Count);

		foreach (var element in _characterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//魂共鸣id
		SerializeUtils.WriteShort(stream, (short)_soulResonanceIds.Count);

		foreach (var element in _soulResonanceIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
        //书院技能书编号
        SerializeUtils.WriteShort(stream, (short)_collegeBookIdList.Count);

        foreach (var element in _collegeBookIdList)
        {
            SerializeUtils.WriteInt(stream, element);
        }
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//出战角色id
		int _characterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterIds_length; ++i) 
		{
			_characterIds.Add(SerializeUtils.ReadInt(stream));
		}
		//魂共鸣id
		int _soulResonanceIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulResonanceIds_length; ++i) 
		{
			_soulResonanceIds.Add(SerializeUtils.ReadInt(stream));
		}
        //书院技能书编号
        int _collegeBookIdList_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _collegeBookIdList_length; ++i)
        {
            _collegeBookIdList.Add(SerializeUtils.ReadInt(stream));
        }
	}
	
	/**
	 * get 出战角色id
	 * @return 
	 */
	public List<int> GetCharacterIds()
	{
		return _characterIds;
	}
	
	/**
	 * set 出战角色id
	 */
	public void SetCharacterIds(List<int> characterIds)
	{
		_characterIds = characterIds;
	}
	
	/**
	 * get 魂共鸣id
	 * @return 
	 */
	public List<int> GetSoulResonanceIds()
	{
		return _soulResonanceIds;
	}
	
	/**
	 * set 魂共鸣id
	 */
	public void SetSoulResonanceIds(List<int> soulResonanceIds)
	{
		_soulResonanceIds = soulResonanceIds;
	}

    /**
 * get 书院技能书编号
 * @return 
 */
    public List<int> GetCollegeBookIdList()
    {
        return _collegeBookIdList;
    }

    /**
     * set 书院技能书编号
     */
    public void SetCollegeBookIdList(List<int> collegeBookIdList)
    {
        _collegeBookIdList = collegeBookIdList;
    }
	public override int GetId() 
	{
		return 112203;
	}
}